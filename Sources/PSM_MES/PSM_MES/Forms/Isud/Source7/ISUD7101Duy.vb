Public Class ISUD7101Duy
#Region "Variable"
    Private wJOB As Integer

    Private CustomerCodeID As String

    Private L_Option1 As String
    Private L_Option2 As String
    Private L_Option3 As String
    Private L_Option4 As String
    Private L_Option5 As String
    Private L_Option6 As String
    Private L_Option7 As String
    Private L_Option8 As String
    Private L_Option9 As String
    Private L_Option10 As String

    Private WRITE_CHK As String
    Private formA As Boolean

    Private Datas As DataSet

    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7101Duy(job As Integer, CustomerCode As String,
                                                    Optional ByVal TAG As String = "") As Boolean

        Link_ISUD7101Duy = False

        Try
            Me.Tag = TAG
            wJOB = job

            CustomerCodeID = CustomerCode

            Select Case job
                Case 1
                Case Else
                    If DATA_SEARCH() = False Then
                        Call MsgBoxP("3", "Not Data")

                        Exit Function
                    End If

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7101Duy = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Material Approved Processing"))
        End Try
    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""


        Me.Text = Me.Text & " - Check Option table PFK7101"
        Frame1.Enabled = True

        'If CHK(5) <> "1" Then
        '    isudCHK = False
        '    formA = True
        '    Me.Dispose()
        '    Call MsgBoxP("You have no right is this program !")
        '    Exit Sub
        'End If


        formA = True
    End Sub

#End Region

#Region "Search"

    Private Function DATA_SEARCH() As Boolean
        DATA_SEARCH = False
        Try
            Datas = PrcDS("USP_ISUD7101Duy_SEARCH", cn, CustomerCodeID)

            L_Option1 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption1").ToString
            L_Option2 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption2").ToString
            L_Option3 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption3").ToString
            L_Option4 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption4").ToString
            L_Option5 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption5").ToString
            L_Option6 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption6").ToString
            L_Option7 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption7").ToString
            L_Option8 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption8").ToString
            L_Option9 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption9").ToString
            L_Option10 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption10").ToString

            Set_Option()

            DATA_SEARCH = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH")
        End Try
    End Function

    Private Sub Set_Option()

        If L_Option1 = "1" Then chk_Option1.Checked = True Else chk_Option1.Checked = False
        If L_Option2 = "1" Then chk_Option2.Checked = True Else chk_Option2.Checked = False
        If L_Option3 = "1" Then chk_Option3.Checked = True Else chk_Option3.Checked = False
        If L_Option4 = "1" Then chk_Option4.Checked = True Else chk_Option4.Checked = False
        If L_Option5 = "1" Then chk_Option5.Checked = True Else chk_Option5.Checked = False
        If L_Option6 = "1" Then chk_Option6.Checked = True Else chk_Option6.Checked = False
        If L_Option7 = "1" Then chk_Option7.Checked = True Else chk_Option7.Checked = False
        If L_Option8 = "1" Then chk_Option8.Checked = True Else chk_Option8.Checked = False
        If L_Option9 = "1" Then chk_Option9.Checked = True Else chk_Option9.Checked = False
        If L_Option10 = "1" Then chk_Option10.Checked = True Else chk_Option10.Checked = False

    End Sub

    Private Sub Get_Option()

        If chk_Option1.Checked = True Then L_Option1 = "1" Else L_Option1 = "2"
        If chk_Option2.Checked = True Then L_Option2 = "1" Else L_Option2 = "2"
        If chk_Option3.Checked = True Then L_Option3 = "1" Else L_Option3 = "2"
        If chk_Option4.Checked = True Then L_Option4 = "1" Else L_Option4 = "2"
        If chk_Option5.Checked = True Then L_Option5 = "1" Else L_Option5 = "2"
        If chk_Option6.Checked = True Then L_Option6 = "1" Else L_Option6 = "2"
        If chk_Option7.Checked = True Then L_Option7 = "1" Else L_Option7 = "2"
        If chk_Option8.Checked = True Then L_Option8 = "1" Else L_Option8 = "2"
        If chk_Option9.Checked = True Then L_Option9 = "1" Else L_Option9 = "2"
        If chk_Option10.Checked = True Then L_Option10 = "1" Else L_Option10 = "2"

    End Sub


    

    Private Function DATA_UPDATE() As Boolean
        DATA_UPDATE = False
        Try
            Get_Option()

            Datas = PrcDS("USP_ISUD7101Duy_UPDATE", cn, CustomerCodeID, L_Option1, L_Option2, L_Option3, L_Option4, L_Option5, L_Option6, L_Option7, L_Option8, L_Option9, L_Option10)
            If Datas.Tables(0)(0)(0).ToString() = "1" Then
                DATA_UPDATE = True
            Else
                DATA_UPDATE = False
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Function


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
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