Public Class HLP7108A

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long
    Private Dsu02 As Long
    Private Dsu03 As Long
    Private formA As Boolean = False
    Private Form_Close As Boolean

#End Region

#Region "Formload"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        Call DATA_INIT()
        Call DATA_SEARCH01()
        Call DATA_SEARCH02(getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex), getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex))
    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
    End Sub

    Public Function Link_HLP7108A(Optional ByVal TAG As String = "") As Boolean
        Link_HLP7108A = False
        Me.Tag = TAG

        Try
            formA = False

            Me.ShowDialog()
            Link_HLP7108A = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try
    End Function
    Public Function Link_HLP7108A_SHOESCODE(ByVal SHOESCODE As String, Optional ByVal TAG As String = "") As Boolean
        Link_HLP7108A_SHOESCODE = False
        txt_ShoesCode.Code = SHOESCODE

        If READ_PFK7106(SHOESCODE) Then
            txt_ShoesCode.Data = D7106.Article & "-" & D7106.Line & "-" & D7106.ColorName
        End If

        Me.Tag = TAG

        Try
            formA = False

            Me.ShowDialog()
            Link_HLP7108A_SHOESCODE = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try
    End Function

    Private Sub DATA_INIT()

    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        If txt_ShoesCode.Data = "" Then txt_ShoesCode.Code = ""
        Vs1.Enabled = False

        If txt_ShoesCode.Code <> "" Then
            DS1 = PrcDS("USP_HLP7108A_SEARCH_VS1_F1", cn, txt_ShoesCode.Code)
            If GetDsRc(DS1) = 0 Then
                Vs1.Enabled = True
                Vs1.ActiveSheet.RowCount = 0
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7108A_SEARCH_VS1_F1", "Vs1")

            Vs1.Enabled = True
            DATA_SEARCH01 = True

        Else
            DS1 = PrcDS("USP_HLP7108A_SEARCH_VS1", cn, txt_ShoesCode.Data)

            If GetDsRc(DS1) = 0 Then
                Vs1.Enabled = True
                Vs1.ActiveSheet.RowCount = 0
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7108A_SEARCH_VS1", "Vs1")

            Vs1.Enabled = True
            DATA_SEARCH01 = True
        End If
    End Function

    Private Function DATA_SEARCH02(KSEL As String, Optional KNAME As String = Nothing) As Boolean
        Dim DSNEW As New DataSet

        DATA_SEARCH02 = False

        Try
            DSNEW = PrcDS("USP_HLP7108A_SEARCH_VS2", cn, KSEL)

            If GetDsRc(DSNEW) = 0 Then
                Vs2.ActiveSheet.RowCount = 0
                Exit Function
            End If

            SPR_PRO_NEW(Vs2, DSNEW, "USP_HLP7108A_SEARCH_VS2", "Vs2")

            DATA_SEARCH02 = True
        Catch ex As Exception

        End Try
    End Function

#End Region

#Region "EVENT"

    Private Sub Vs1_CellClick1(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.ColumnHeader = True Then Exit Sub
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub
    Private Sub Vs2_CellClick1(sender As Object, e As CellClickEventArgs) Handles Vs2.CellClick
        If e.ColumnHeader = True Then Exit Sub
        Vs2.ActiveSheet.ActiveRowIndex = e.Row
        Vs2.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub
    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If e.ColumnHeader = True Then Exit Sub
        If getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        Vs1.Enabled = False
        Dim str As String
        str = getData(Vs1, 0, e.Row)
        DATA_SEARCH02(str)
        Vs1.Enabled = True
    End Sub

    Private Sub Vs1_KeyUp(sender As Object, e As KeyEventArgs) Handles Vs1.KeyUp
        Select Case e.KeyCode
            Case Keys.Down, Keys.Up, Keys.PageDown, Keys.PageUp
                Call vS1_Click(Vs1.ActiveSheet.ActiveColumnIndex, Vs1.ActiveSheet.ActiveRowIndex)
        End Select
    End Sub

    Private Sub vS1_Click(ByVal Col As Long, ByVal Row As Long)
        If Row < 0 Then Exit Sub
        If getData(Vs1, 12, Row) = "" Then Exit Sub
        Call DATA_SEARCH02(getData(Vs1, 0, Row), getData(Vs1, 1, Row))
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH01() = True Then

        End If
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex) IsNot Nothing Then
            If getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex) <> "" Then
                hlp0000SeVa = getData(Vs2, 1, Vs2.ActiveSheet.ActiveRowIndex)
                hlp0000SeVaTt = getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex)
                hlp0000SeVaTt1 = getData(Vs1, 2, Vs1.ActiveSheet.ActiveRowIndex)
                isudCHK = True
            End If
        Else
            hlp0000SeVa = ""
            hlp0000SeVaTt = ""
            hlp0000SeVaTt1 = ""
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