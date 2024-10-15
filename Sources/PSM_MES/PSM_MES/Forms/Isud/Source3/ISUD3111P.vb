Public Class ISUD3111P

#Region "Variable"
    Private wJOB As Integer

    Private W3111 As T3111_AREA
    Private L3111 As T3111_AREA

    Private W3113 As T3113_AREA
    Private L3113 As T3113_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD3113P(job As Integer, RequestPurchasingNo As String, RequestPurchasingSeq As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        D3113.RequestPurchasingNo = RequestPurchasingNo
        D3113.RequestPurchasingSeq = RequestPurchasingSeq
        wJOB = job : L3113 = D3113

        Link_ISUD3113P = False


        Try

            formA = False
            Me.ShowDialog()

            Link_ISUD3113P = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
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
                Call MsgBoxP("Only Search !"): cmd_OK.Visible = False
            End If
        End If

        If APPROVAL_CHECK() = False Then Call Block_Check()

        formA = True
    End Sub
    
#End Region

#Region "Search"
    Private Function APPROVAL_CHECK() As Boolean

        APPROVAL_CHECK = False


        If READ_PFK3113(L3113.RequestPurchasingNo, L3113.RequestPurchasingSeq) = False Then
            Exit Function
        End If

        L3113 = D3113

        K3113_CheckRequestPurchasing(L3113.CheckRequestPurchasing)

        If Purchasing_Check(L3113) = False Then MsgBoxP("Purchasing had data already!") : Exit Function

        APPROVAL_CHECK = True

    End Function

#End Region

#Region "Functions"
    Private Sub Block_Check()
        rad_CheckProcessPurchsing1.Enabled = False
        rad_CheckProcessPurchsing2.Enabled = True
        rad_CheckProcessPurchsing3.Enabled = True
        rad_CheckProcessPurchsing4.Enabled = True
        rad_CheckProcessPurchsing5.Enabled = False
    End Sub
    Private Function Purchasing_Check(z3113 As T3113_AREA) As Boolean
        Purchasing_Check = False

        If z3113.WgtGrossInboundYarn > 0 Or z3113.WgtNetInboundYarn > 0 Then Exit Function

        Purchasing_Check = True
    End Function

    Private Sub K3113_CheckRequestPurchasing(Process As String)
        Select Case Process
            Case "1" : rad_CheckProcessPurchsing1.Checked = True
            Case "2" : rad_CheckProcessPurchsing2.Checked = True
            Case "3" : rad_CheckProcessPurchsing3.Checked = True
            Case "4" : rad_CheckProcessPurchsing4.Checked = True
            Case "6" : rad_CheckProcessPurchsing5.Checked = True
            Case Else : rad_CheckProcessPurchsing1.Checked = True
        End Select
    End Sub
    Private Sub K3113_CheckRequestPurchasing()
        If rad_CheckProcessPurchsing1.Checked = True Then W3113.CheckRequestPurchasing = "1"
        If rad_CheckProcessPurchsing2.Checked = True Then W3113.CheckRequestPurchasing = "2"
        If rad_CheckProcessPurchsing3.Checked = True Then W3113.CheckRequestPurchasing = "3"
        If rad_CheckProcessPurchsing4.Checked = True Then W3113.CheckRequestPurchasing = "4"
        If rad_CheckProcessPurchsing5.Checked = True Then W3113.CheckRequestPurchasing = "6"
    End Sub
    Private Sub Enable_CheckRequestPurchasing(check1 As Boolean, check2 As Boolean, check3 As Boolean, check4 As Boolean, check5 As Boolean)
        rad_CheckProcessPurchsing1.Enabled = check1
        rad_CheckProcessPurchsing2.Enabled = check2
        rad_CheckProcessPurchsing3.Enabled = check3
        rad_CheckProcessPurchsing4.Enabled = check4
        rad_CheckProcessPurchsing5.Enabled = check5
    End Sub

    Private Function DATA_UPDATE() As Boolean
        DATA_UPDATE = False
        Try
            If READ_PFK3113(L3113.RequestPurchasingNo, L3113.RequestPurchasingSeq) = True Then
                W3113 = D3113
                K3113_CheckRequestPurchasing()
                If REWRITE_PFK3113(W3113) = True Then

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

            If CHK(5) <> "1" And rad_CheckProcessPurchsing3.Checked = True Then
                Call MsgBoxP("No right to update this!")
                Exit Sub
            End If

            If CHK(5) <> "1" And rad_CheckProcessPurchsing2.Checked = True Then
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