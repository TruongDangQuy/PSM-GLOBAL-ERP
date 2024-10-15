Public Class HLP7108B

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

    Public Function Link_HLP7108B(Optional ByVal TAG As String = "") As Boolean
        Link_HLP7108B = False
        Me.Tag = TAG

        Try
            formA = False
            Me.ShowDialog()
            Link_HLP7108B = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link HLP7108B!"))
        End Try

    End Function
    Public Function Link_HLP7108B_SHOESCODE(ByVal SHOESCODE As String, Optional ByVal TAG As String = "") As Boolean
        Link_HLP7108B_SHOESCODE = False
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
            Link_HLP7108B_SHOESCODE = isudCHK

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
            DSNEW = PrcDS("USP_HLP7108B_SEARCH_VS1", cn, ShoesCode)

            If GetDsRc(DSNEW) = 0 Then
                Vs1.ActiveSheet.RowCount = 0
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DSNEW, "USP_HLP7108B_SEARCH_VS1", "Vs1")

            DATA_SEARCH01 = True

        Catch ex As Exception

        End Try

    End Function
#End Region

#Region "Events"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click

        If getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentBOM"), Vs1.ActiveSheet.ActiveRowIndex) IsNot Nothing Then
            If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) <> "" Then

                hlp0000SeVaTt = getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentBOM"), Vs1.ActiveSheet.ActiveRowIndex)
                hlp0000SeVaTt1 = getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentSeq"), Vs1.ActiveSheet.ActiveRowIndex)

                D7109.GroupComponentBOM = getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentBOM"), Vs1.ActiveSheet.ActiveRowIndex)
                D7109.GroupComponentSeq = getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentSeq"), Vs1.ActiveSheet.ActiveRowIndex)
                D7109.MaterialCode = getData(Vs1, getColumIndex(Vs1, "KEY_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex)

                hlp0000SeVa = getData(Vs1, getColumIndex(Vs1, "SPEC_SWICH"), Vs1.ActiveSheet.ActiveRowIndex)
                D7113.Autokey = getData(Vs1, getColumIndex(Vs1, "K7113_Autokey"), Vs1.ActiveSheet.ActiveRowIndex)

                isudCHK = True
            End If
        Else
            hlp0000SeVa = ""
            hlp0000SeVaTt = ""
            hlp0000SeVaTt1 = ""

            D7109.GroupComponentBOM = ""
            D7109.GroupComponentSeq = ""
            D7109.MaterialCode = ""

            isudCHK = False
        End If
        Me.Close()

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