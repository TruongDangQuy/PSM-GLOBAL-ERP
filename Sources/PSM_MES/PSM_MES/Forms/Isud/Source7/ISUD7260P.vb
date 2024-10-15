Public Class ISUD7260P

#Region "Variable"
    Private wJOB As Integer

    Private W7260 As New T7260_AREA
    Private L7260 As New T7260_AREA

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
    Public Function Link_ISUD7260P(job As Integer, ContractID As String,
                                                    Status1 As String,
                                                    Status2 As String,
                                                    Status3 As String,
                                                    Status4 As String,
                                                    Status5 As String,
                                                    Status6 As String,
                                                    Optional ByVal TAG As String = "") As Boolean

        Link_ISUD7260P = False

        Try
            Me.Tag = TAG
            wJOB = job

            D7260.ContractID = ContractID
            L7260 = D7260


            L_Status1 = Status1
            L_Status2 = Status2
            L_Status3 = Status3
            L_Status4 = Status4
            L_Status5 = Status5
            L_Status6 = Status6

            Select Case job
                Case 1
                Case Else
                    If READ_PFK7260(L7260.ContractID) = False Then
                        Call MsgBoxP("3", "Not Data")

                        Exit Function
                    Else
                        L7260.CheckSupplierPrice = D7260.CheckSupplierPrice

                        If L7260.CheckSupplierPrice = "3" Then
                            L_Status1 = "1"
                            L_Status2 = "1"
                            L_Status3 = "1"
                            L_Status4 = "1"
                            L_Status5 = "2"
                            L_Status6 = "2"
                        End If

                        If L7260.CheckSupplierPrice = "2" Or L7260.CheckSupplierPrice = "4" Then
                            L_Status1 = "2"
                            L_Status2 = "1"
                            L_Status3 = "1"
                            L_Status4 = "1"
                            L_Status5 = "2"
                            L_Status6 = "2"
                        End If

                        If L7260.CheckSupplierPrice = "1" Or L7260.CheckSupplierPrice = "" Then
                            L_Status1 = "1"
                            L_Status2 = "2"
                            L_Status3 = "1"
                            L_Status4 = "2"
                            L_Status5 = "2"
                            L_Status6 = "2"
                        End If

                        If L7260.CheckSupplierPrice = "5" Or L7260.CheckSupplierPrice = "6" Then
                            L_Status1 = "1"
                            L_Status2 = "2"
                            L_Status3 = "1"
                            L_Status4 = "2"
                            L_Status5 = "1"
                            L_Status6 = "1"
                        End If
                    End If

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7260P = isudCHK


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

        If bolCheckRNDPrice = False Then
            If MsgBoxPPW("Please type the password to modify!", const_pwMRNDPrice) = False Then wJOB = "2" : cmd_OK.Visible = False Else bolCheckRNDPrice = True
        End If

        If CHK(5) <> "1" Then
            isudCHK = False
            formA = True
            Me.Dispose()
            Call MsgBoxP("You have no right is this program !")
            Exit Sub
        End If

        Call Block_Check()
        Call K7260_CheckSupplierPrice(L7260.CheckSupplierPrice)

        formA = True
    End Sub

#End Region

#Region "Search"
    Private Sub Block_Check()

        If L_Status1 = "1" Then rad_CheckSupplierPrice1.Enabled = True Else rad_CheckSupplierPrice1.Enabled = False
        If L_Status2 = "1" Then rad_CheckSupplierPrice2.Enabled = True Else rad_CheckSupplierPrice2.Enabled = False
        If L_Status3 = "1" Then rad_CheckSupplierPrice3.Enabled = True Else rad_CheckSupplierPrice3.Enabled = False
        If L_Status4 = "1" Then rad_CheckSupplierPrice4.Enabled = True Else rad_CheckSupplierPrice4.Enabled = False
        If L_Status5 = "1" Then rad_CheckSupplierPrice5.Enabled = True Else rad_CheckSupplierPrice5.Enabled = False
        If L_Status6 = "1" Then rad_CheckSupplierPrice6.Enabled = True Else rad_CheckSupplierPrice6.Enabled = False

    End Sub

    Private Sub Wrea_Check(Process As String)
        Select Case Process
            Case "1"
                rad_CheckSupplierPrice1.Enabled = True
                rad_CheckSupplierPrice2.Enabled = False
                rad_CheckSupplierPrice3.Enabled = False
                rad_CheckSupplierPrice4.Enabled = False
                rad_CheckSupplierPrice5.Enabled = True
                rad_CheckSupplierPrice6.Enabled = False

            Case "2"
                rad_CheckSupplierPrice1.Enabled = False
                rad_CheckSupplierPrice2.Enabled = False
                rad_CheckSupplierPrice3.Enabled = False
                rad_CheckSupplierPrice4.Enabled = False
                rad_CheckSupplierPrice5.Enabled = False
                rad_CheckSupplierPrice6.Enabled = False

            Case "3"
                rad_CheckSupplierPrice1.Enabled = False
                rad_CheckSupplierPrice2.Enabled = False
                rad_CheckSupplierPrice3.Enabled = False
                rad_CheckSupplierPrice4.Enabled = False
                rad_CheckSupplierPrice5.Enabled = False
                rad_CheckSupplierPrice6.Enabled = False

            Case "4"
                rad_CheckSupplierPrice1.Enabled = False
                rad_CheckSupplierPrice2.Enabled = False
                rad_CheckSupplierPrice3.Enabled = False
                rad_CheckSupplierPrice4.Enabled = True
                rad_CheckSupplierPrice5.Enabled = False
                rad_CheckSupplierPrice6.Enabled = False
            Case "5"
                rad_CheckSupplierPrice1.Enabled = True
                rad_CheckSupplierPrice2.Enabled = False
                rad_CheckSupplierPrice3.Enabled = False
                rad_CheckSupplierPrice4.Enabled = False
                rad_CheckSupplierPrice5.Enabled = True
                rad_CheckSupplierPrice6.Enabled = True

            Case "6"
                rad_CheckSupplierPrice1.Enabled = False
                rad_CheckSupplierPrice2.Enabled = False
                rad_CheckSupplierPrice3.Enabled = True
                rad_CheckSupplierPrice4.Enabled = False
                rad_CheckSupplierPrice5.Enabled = True
                rad_CheckSupplierPrice6.Enabled = True
        End Select

    End Sub

    Private Sub K7260_CheckSupplierPrice(Process As String)
        Select Case Process
            Case "1" : rad_CheckSupplierPrice1.Checked = True
            Case "2" : rad_CheckSupplierPrice2.Checked = True
            Case "3" : rad_CheckSupplierPrice3.Checked = True
            Case "4" : rad_CheckSupplierPrice4.Checked = True
            Case "5" : rad_CheckSupplierPrice5.Checked = True
            Case "6" : rad_CheckSupplierPrice6.Checked = True
            Case Else : rad_CheckSupplierPrice1.Checked = True
        End Select
    End Sub
    Private Sub K7260_CheckSupplierPrice()
        If rad_CheckSupplierPrice1.Checked = True Then W7260.CheckSupplierPrice = "1"
        If rad_CheckSupplierPrice2.Checked = True Then W7260.CheckSupplierPrice = "2" : W7260.DateComplete = Pub.DAT
        If rad_CheckSupplierPrice3.Checked = True Then W7260.CheckSupplierPrice = "3" : W7260.DateApproved = Pub.DAT
        If rad_CheckSupplierPrice4.Checked = True Then W7260.CheckSupplierPrice = "4" : W7260.DateCancel = Pub.DAT
        If rad_CheckSupplierPrice5.Checked = True Then W7260.CheckSupplierPrice = "5" : W7260.DatePending1 = Pub.DAT
        If rad_CheckSupplierPrice6.Checked = True Then W7260.CheckSupplierPrice = "6" : W7260.DatePending2 = Pub.DAT
    End Sub

    Private Function DATA_UPDATE() As Boolean
        DATA_UPDATE = False
        Try
            If READ_PFK7260(L7260.ContractID) = True Then
                W7260 = D7260
                Call K7260_CheckSupplierPrice()

                If REWRITE_PFK7260(W7260) = True Then
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

            If CHK(5) <> "1" And rad_CheckSupplierPrice3.Checked = True Then
                Call MsgBoxP("No right to update this!")
                Exit Sub
            End If

            If CHK(5) <> "1" And rad_CheckSupplierPrice2.Checked = True Then
                Call MsgBoxP("No right to update this!")
                Exit Sub
            End If

            Select Case wJOB
                Case "1", "2", "3", "4", "5", "6"
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
