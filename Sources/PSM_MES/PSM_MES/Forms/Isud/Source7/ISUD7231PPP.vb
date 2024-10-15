Public Class ISUD7231PPP

#Region "Variable"
    Private wJOB As Integer

    Private W7231 As New T7231_AREA
    Private L7231 As New T7231_AREA

    Private WRITE_CHK As String
    Private formA As Boolean

    Private L_Status1 As String
    Private L_Status2 As String
    Private L_Status3 As String
    Private L_Status4 As String
    Private L_Status5 As String
    Private L_Status6 As String

    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7231PPP(job As Integer, MaterialCode As String,
                                                    Status1 As String,
                                                    Status2 As String,
                                                    Status3 As String,
                                                    Status4 As String,
                                                    Status5 As String,
                                                    Status6 As String,
                                                    Optional ByVal TAG As String = "") As Boolean

        Link_ISUD7231PPP = False

        Try
            Me.Tag = TAG

            wJOB = job
            D7231.MaterialCode = MaterialCode
            L7231 = D7231

            L_Status1 = Status1
            L_Status2 = Status2
            L_Status3 = Status3
            L_Status4 = Status4
            L_Status5 = Status5
            L_Status6 = Status6

            Select Case job
                Case 1
                Case Else
                    If READ_PFK7231(L7231.MaterialCode) = False Then
                        Call MsgBoxP("3", "Not Data")

                        Exit Function
                    End If

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7231PPP = isudCHK
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

        Call Block_Check()

        formA = True
    End Sub

#End Region

#Region "Search"
    Private Sub Block_Check()
        If L_Status1 = "1" Then rad_StatusMaterial1.Enabled = True Else rad_StatusMaterial1.Enabled = False
        If L_Status2 = "1" Then rad_StatusMaterial2.Enabled = True Else rad_StatusMaterial2.Enabled = False
        If L_Status3 = "1" Then rad_StatusMaterial3.Enabled = True Else rad_StatusMaterial3.Enabled = False
        If L_Status4 = "1" Then rad_StatusMaterial4.Enabled = True Else rad_StatusMaterial4.Enabled = False
        If L_Status5 = "1" Then rad_StatusMaterial5.Enabled = True Else rad_StatusMaterial5.Enabled = False
        If L_Status6 = "1" Then rad_StatusMaterial6.Enabled = True Else rad_StatusMaterial6.Enabled = False
    End Sub

    Private Sub K7231_StatusMaterial(Process As String)
        Select Case Process
            Case "1" : rad_StatusMaterial1.Checked = True
            Case "2" : rad_StatusMaterial2.Checked = True
            Case "3" : rad_StatusMaterial3.Checked = True
            Case "4" : rad_StatusMaterial4.Checked = True
            Case "5" : rad_StatusMaterial5.Checked = True
            Case "6" : rad_StatusMaterial6.Checked = True
            Case Else : rad_StatusMaterial1.Checked = True
        End Select
    End Sub
    Private Sub K7231_StatusMaterial()
        If rad_StatusMaterial1.Checked = True Then W7231.StatusMaterial = "1"
        If rad_StatusMaterial2.Checked = True Then W7231.StatusMaterial = "2" : W7231.DateComplete = Pub.DAT
        If rad_StatusMaterial3.Checked = True Then W7231.StatusMaterial = "3" : W7231.DateApproved = Pub.DAT
        If rad_StatusMaterial4.Checked = True Then W7231.StatusMaterial = "4" : W7231.DateCancel = Pub.DAT
        If rad_StatusMaterial5.Checked = True Then W7231.StatusMaterial = "5" : W7231.DatePending1 = Pub.DAT
        If rad_StatusMaterial6.Checked = True Then W7231.StatusMaterial = "6" : W7231.DatePending2 = Pub.DAT
    End Sub

    Private Function DATA_UPDATE() As Boolean
        DATA_UPDATE = False
        Try
            If READ_PFK7231(L7231.MaterialCode) = True Then
                W7231 = D7231

                Call K7231_StatusMaterial()

                If REWRITE_PFK7231(W7231) = True Then
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
            Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

            If CHK(5) <> "1" And rad_StatusMaterial3.Checked = True Then
                Call MsgBoxP("No right to update this!")
                Exit Sub
            End If

            If CHK(5) <> "1" And rad_StatusMaterial2.Checked = True Then
                Call MsgBoxP("No right to update this!")
                Exit Sub
            End If

            Select Case wJOB
                Case "3"
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
