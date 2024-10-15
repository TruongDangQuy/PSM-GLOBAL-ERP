Public Class FPopUp

#Region "Variable"
    Private aMessage As String

    Private formA As Boolean
    Private isudCHK As Boolean

    Private strxFormName As String

#End Region

#Region "Form_Load"

#End Region

#Region "Methods"
    Public Function Link_FPopUp(xFormName As String) As Boolean
        Link_FPopUp = False
        Try
            formA = False
            strxFormName = xFormName

            If READ_PFK9950_ProgramNo(xFormName) Then
                txt_Message.Text = D9950.Content
            End If

            Me.ShowDialog()

            Link_FPopUp = isudCHK

        Catch ex As Exception
            Call MsgBoxP("Link_FPopUp")
        End Try
    End Function
#End Region

#Region "Events"


    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        isudCHK = False
        If chk_Notice.Checked Then
            If READ_PFK9950_ProgramNo(strxFormName) Then
                If READ_PFK9951(D9950.Autokey, Pub.SAW) = False Then
                    D9951.Autokey = D9950.Autokey
                    D9951.IDNO = Pub.SAW
                    Call WRITE_PFK9951(D9951)
                End If
            End If
        End If

        Me.Dispose()
    End Sub

#End Region





End Class