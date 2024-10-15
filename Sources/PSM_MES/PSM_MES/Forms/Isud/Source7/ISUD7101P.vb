Public Class ISUD7101P

#Region "Variable"
    Private wJOB As Integer

    Private W7101 As New T7101_AREA
    Private L7101 As New T7101_AREA

    Private L_Status1 As String
    Private L_Status2 As String
    Private L_Status3 As String
    Private L_Status4 As String
    Private L_Status5 As String
    Private L_Status6 As String

    Private WRITE_CHK As String
    Private formA As Boolean

    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7101P(job As Integer, CustomerCode As String,
                                                    Status1 As String,
                                                    Status2 As String,
                                                    Status3 As String,
                                                    Status4 As String,
                                                    Status5 As String,
                                                    Status6 As String,
                                                    Optional ByVal TAG As String = "") As Boolean

        Link_ISUD7101P = False

        Try
            Me.Tag = TAG
            wJOB = job

            D7101.CustomerCode = CustomerCode
            L7101 = D7101

            L_Status1 = Status1
            L_Status2 = Status2
            L_Status3 = Status3
            L_Status4 = Status4
            L_Status5 = Status5
            L_Status6 = Status6

            Select Case job
                Case 1
                Case Else
                    If READ_PFK7101(L7101.CustomerCode) = False Then
                        Call MsgBoxP("3", "Not Data")

                        Exit Function
                    End If

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7101P = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Material Approved Processing"))
        End Try
    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Me.Text = Me.Text & " - APPROVED"
        Frame1.Enabled = True

        If CHK(5) <> "1" Then
            isudCHK = False
            formA = True
            Me.Dispose()
            Call MsgBoxP("You have no right is this program !")
            Exit Sub
        End If

        Call Block_Check()

        If READ_PFK7101(D7101.CustomerCode) = True Then Call K7101_CheckCustomerStatus(D7101.CheckCustomerStatus)

        formA = True
    End Sub

#End Region

#Region "Search"
    Private Sub Block_Check()

        If L_Status1 = "1" Then rad_CheckCustomerStatus1.Enabled = True Else rad_CheckCustomerStatus1.Enabled = False
        If L_Status2 = "1" Then rad_CheckCustomerStatus2.Enabled = True Else rad_CheckCustomerStatus2.Enabled = False
        If L_Status3 = "1" Then rad_CheckCustomerStatus3.Enabled = True Else rad_CheckCustomerStatus3.Enabled = False
        If L_Status4 = "1" Then rad_CheckCustomerStatus4.Enabled = True Else rad_CheckCustomerStatus4.Enabled = False
        If L_Status5 = "1" Then rad_CheckCustomerStatus5.Enabled = True Else rad_CheckCustomerStatus5.Enabled = False
        If L_Status6 = "1" Then rad_CheckCustomerStatus6.Enabled = True Else rad_CheckCustomerStatus6.Enabled = False

    End Sub

    Private Sub K7101_CheckCustomerStatus(Process As String)
        Select Case Process
            Case "1" : rad_CheckCustomerStatus1.Checked = True
            Case "2" : rad_CheckCustomerStatus2.Checked = True
            Case "3" : rad_CheckCustomerStatus3.Checked = True
            Case "4" : rad_CheckCustomerStatus4.Checked = True
            Case "5" : rad_CheckCustomerStatus5.Checked = True
            Case "6" : rad_CheckCustomerStatus6.Checked = True
            Case Else : rad_CheckCustomerStatus1.Checked = True
        End Select
    End Sub
    Private Sub K7101_CheckCustomerStatus()
        If rad_CheckCustomerStatus1.Checked = True Then W7101.CheckCustomerStatus = "1"
        If rad_CheckCustomerStatus2.Checked = True Then W7101.CheckCustomerStatus = "2" : W7101.DateComplete = Pub.DAT
        If rad_CheckCustomerStatus3.Checked = True Then W7101.CheckCustomerStatus = "3" : W7101.DateApproved = Pub.DAT
        If rad_CheckCustomerStatus4.Checked = True Then W7101.CheckCustomerStatus = "4" : W7101.DateCancel = Pub.DAT
        If rad_CheckCustomerStatus5.Checked = True Then W7101.CheckCustomerStatus = "5" : W7101.DatePending1 = Pub.DAT
        If rad_CheckCustomerStatus6.Checked = True Then W7101.CheckCustomerStatus = "6" : W7101.DatePending2 = Pub.DAT
    End Sub

    Private Function DATA_UPDATE() As Boolean
        DATA_UPDATE = False
        Try
            If READ_PFK7101(L7101.CustomerCode) = True Then
                W7101 = D7101
                Call K7101_CheckCustomerStatus()
                If REWRITE_PFK7101(W7101) = True Then
                    isudCHK = True
                End If
            End If

            DATA_UPDATE = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Function


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
            'Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

            'If CHK(5) <> "1" And rad_CheckCustomerStatus3.Checked = True Then
            '    Call MsgBoxP("No right to update this!")
            '    Exit Sub
            'End If

            'If CHK(5) <> "1" And rad_CheckCustomerStatus2.Checked = True Then
            '    Call MsgBoxP("No right to update this!")
            '    Exit Sub
            'End If

            Select Case wJOB
                Case "5"
                    If DATA_UPDATE() = True Then
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
