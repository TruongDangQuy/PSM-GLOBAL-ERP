Public Class ISUD7411D
#Region "Variable"
    Private wJOB As Integer

    Private CustomerCodeID As String

    Private WRITE_CHK As String
    Private formA As Boolean

    Private Datas As DataSet

    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7411D(job As Integer, CustomerCode As String,
                                                    Optional ByVal TAG As String = "") As Boolean

        Link_ISUD7411D = False

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

            Link_ISUD7411D = isudCHK

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
            'Datas = PrcDS("USP_ISUD7101Duy_SEARCH", cn, CustomerCodeID)

            'L_Option1 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption1").ToString
            'L_Option2 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption2").ToString
            'L_Option3 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption3").ToString
            'L_Option4 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption4").ToString
            'L_Option5 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption5").ToString
            'L_Option6 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption6").ToString
            'L_Option7 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption7").ToString
            'L_Option8 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption8").ToString
            'L_Option9 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption9").ToString
            'L_Option10 = Datas.Tables(0)(0)("ISUD7101Duy_CheckOption10").ToString



            DATA_SEARCH = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH")
        End Try
    End Function

   
    Private Function DATA_INSERT() As Boolean
        DATA_INSERT = False
        Try

            Datas = PrcDS("USP_INSERT_PFK7411_WEB_CHECK_LOGIN_VS1", cn, txt_Password.Data)
            If Datas.Tables(0)(0)(0).ToString() = "1" Then
                DATA_INSERT = True
            Else
                DATA_INSERT = False
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT")
        End Try
    End Function


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
            Select Case wJOB
                Case "1"
                    If DATA_INSERT() = True Then
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