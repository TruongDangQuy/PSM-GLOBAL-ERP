Public Class HLP4471A

#Region "Variable"
    Private Dsu As Integer
    Private W1_Head As Integer

    Private Dsu01 As Long
    Private a4471() As T4471_AREA

    Private W4471 As T4471_AREA
    Private L4471 As T4471_AREA
#End Region

#Region "Form_Load"
    Public Function Link_HLP4471A(SEL As String, Optional CHK5 As String = "") As Boolean

        L4471.SEL = SEL
        L4471.CHK5 = CHK5

        Me.ShowDialog()
        'Me.Dispose()

        Link_HLP4471A = hlpCHK

        If hlpCHK = False Then Call D4471_CLEAR()

    End Function
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_NAME.Data = ""
        txt_NAME.Code = ""

        W1_Head = 1

        If DATA_SEARCH(W1_Head) = False Then
            Vs1.Enabled = False
            Exit Sub
        End If

        Call DATA_DISPLAY()

    End Sub
#End Region

#Region "Methods"
    Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
        Call INTERRUPT_TOGGLE(KeyCode)
    End Sub

    Private Function DATA_SEARCH(Head_No As Integer) As Boolean
        DATA_SEARCH = False

        Dim i As Integer
        Dim DS01 As New DataSet

        Try

            Vs1.Enabled = True
            cmd_OK.Enabled = True

            SQL = "SELECT * FROM PFK4471 "
            SQL = SQL & " WHERE K4471_SEL = '" & L4471.SEL & "' "
            SQL = SQL & " AND   K4471_NAME like '%" & txt_NAME.Data & "%' "

            If L4471.CHK5 <> "" Then SQL = SQL & " AND   K4471_CHK5  ='" & L4471.CHK5 & "' "

            Select Case Head_No
                Case 1 : SQL = SQL & " ORDER BY K4471_SEQ, K4471_CODE "
                Case 2 : SQL = SQL & " ORDER BY K4471_NAME,K4471_CODE"
            End Select

            cmd = New SqlClient.SqlCommand(SQL, cn)
            DS01 = PrcDS(cmd, cn)

            If GetDsRc(DS01) = 0 Then
                Vs1.Visible = True
                Me.Cursor = Cursors.Default
                cmd_OK.Enabled = True

                Call Error_Message("1", "DATA_SEARCH01")
                Exit Function
            End If

            Dsu01 = GetDsRc(DS01)
            ReDim a4471(0 To Dsu01)

            i = -1

            For Each RS01 As DataRow In DS01.Tables(0).Rows
                i = i + 1
                Vs1.ActiveSheet.RowCount = i + 1
                a4471(i).SEL = RS01!K4471_SEL
                a4471(i).CODE = RS01!K4471_CODE
                a4471(i).NAME = RS01!K4471_NAME
                setData(Vs1, 0, i, a4471(i).CODE)
                setData(Vs1, 1, i, a4471(i).NAME)
            Next

            Vs1.Select()

            DATA_SEARCH = True

        Catch ex As Exception
            Error_Message("62", "DATA_SEARCH")
        End Try

    End Function

    Private Sub DATA_DISPLAY()
        'Call vaSpread_Clear(Vs1)
        'Vs1.Enabled = False

        'Dim i As Integer

        'For i = 0 To Dsu
        '    Vs1.ActiveSheet.ActiveRowIndex = i

        '    Vs1.ActiveSheet.ActiveColumnIndex = 1 : Vs1.Text = a4471(i).CODE
        '    Vs1.ActiveSheet.ActiveColumnIndex = 2 : Vs1.Text = a4471(i).NAME

        'Next i

        'Vs1.Enabled = True

    End Sub
#End Region

#Region "Events"
    Private Sub Vs1_KeyDown(KeyCode As Integer, Shift As Integer)
        Select Case KeyCode
            Case Keys.Return
                Call cmd_OK.PerformClick()
        End Select
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            Exit Sub
        Else
            hlp0000SeVa = getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt = getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
        End If

        hlpCHK = True

        D4471 = a4471(Vs1.ActiveSheet.ActiveRowIndex)

        Me.Dispose()
    End Sub

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlpCHK = False

        Call D4471_CLEAR()

        Me.Dispose()

    End Sub

    Private Sub cmd_INSERT_Click(sender As Object, e As EventArgs) Handles cmd_INSERT.Click
        If DATA_SEARCH(W1_Head) = False Then Setfocus(txt_NAME) : Exit Sub

        Call DATA_DISPLAY()

        Vs1.Select()
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        If DATA_SEARCH(W1_Head) = False Then Setfocus(txt_NAME) : Exit Sub

        Call DATA_DISPLAY()

        Vs1.Select()
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If e.ColumnHeader Or e.RowHeader Then Exit Sub
        Call cmd_OK.PerformClick()
    End Sub

    Private Sub Vs1_KeyDown1(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cmd_OK.PerformClick()
        End If
    End Sub
#End Region

End Class