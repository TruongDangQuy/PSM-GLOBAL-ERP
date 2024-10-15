Public Class HLP7108C

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long
    Private Dsu02 As Long
    Private Dsu03 As Long
    Private formA As Boolean = False
    Private Form_Close As Boolean

#End Region

#Region "Formload"

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
    End Sub

    Public Function Link_HLP7108C(Optional ByVal TAG As String = "") As Boolean
        Link_HLP7108C = False
        Me.Tag = TAG

        Try
            formA = False
            Me.ShowDialog()
            Link_HLP7108C = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link HLP7108B!"))
        End Try

    End Function
    Public Function Link_HLP7108C_SHOESCODE(ByVal SHOESCODE As String, Optional ByVal TAG As String = "") As Boolean
        Link_HLP7108C_SHOESCODE = False
        txt_ShoesCode.Code = SHOESCODE

        If READ_PFK7106(SHOESCODE) = True Then

            txt_ShoesCode.Data = SHOESCODE
            txt_line.Data = D7106.Line
            txt_Article.Data = D7106.Article

        End If

        Me.Tag = TAG

        Try
            formA = False

            Me.ShowDialog()
            Link_HLP7108C_SHOESCODE = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv(""))
        End Try
    End Function

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        If DATA_SEARCH01() = True Then formA = True

    End Sub

#End Region

#Region "Functions"
    Private Function DATA_SEARCH01() As Boolean

        Dim DSNEW As New DataSet

        Dim ShoesCode As String

        DATA_SEARCH01 = False

        ShoesCode = txt_ShoesCode.Code

        Try
            DSNEW = PrcDS("USP_HLP7108C_SEARCH_VS1", cn, ShoesCode)

            If GetDsRc(DSNEW) = 0 Then
                Vs1.ActiveSheet.RowCount = 0
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DSNEW, "USP_HLP7108C_SEARCH_VS1", "Vs1")

            DATA_SEARCH01 = True

        Catch ex As Exception

        End Try

    End Function
#End Region

#Region "Events"

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Dim i As Integer
        Try
            'For i = 0 To Vs1.ActiveSheet.RowCount - 1
            '    If (chk) Then
            '        If getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentBOM"), Vs1.ActiveSheet.ActiveRowIndex) IsNot Nothing Then
            '            If getData(Vs1, i, Vs1.ActiveSheet.ActiveRowIndex) <> "" Then
            '                hlp0000SeVaTt = getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentBOM"), Vs1.ActiveSheet.ActiveRowIndex)
            '                hlp0000SeVaTt1 = getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentSeq"), Vs1.ActiveSheet.ActiveRowIndex)
            '                isudCHK = True
            '            End If
            '        Else
            '            hlp0000SeVaTt = ""
            '            hlp0000SeVaTt1 = ""
            '            isudCHK = False
            '        End If
            '        Me.Close()
            'Next


            hlp0000SeVa = ""
            hlp0000SeVaTt = ""
            '  Dim i As Integer
            Dim CheckValue As Boolean = False

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(Vs1, getColumIndex(Vs1, "CHK"), i) = "1" Then
                    ';hlp0000SeVa &= getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), i) & "|"
                    hlp0000SeVaTt &= getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentBOM"), i) & "|"
                    hlp0000SeVaTt1 &= getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentSeq"), i) & "|"
                End If
            Next
            'hlp0000SeVa = Strings.Left(hlp0000SeVa, Len(hlp0000SeVa) - 1)
            'hlp0000SeVaTt = hlp0000SeVa


            hlp0000SeVaTt = Strings.Left(hlp0000SeVaTt, Len(hlp0000SeVaTt) - 1)
            hlp0000SeVaTt1 = Strings.Left(hlp0000SeVaTt1, Len(hlp0000SeVaTt1) - 1)

            isudCHK = True


            Me.Dispose()

        Catch ex As Exception

        End Try






    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        isudCHK = False
        Me.Close()
    End Sub
#End Region

    




End Class