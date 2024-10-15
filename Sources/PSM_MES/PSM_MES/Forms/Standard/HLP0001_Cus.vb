Public Class HLP0001_Cus
    Public Structure KIEMTRA
        Public check1 As Integer
        Public check2 As Integer
        Public check3 As Integer
        Public check4 As Integer
        Public check5 As Integer
        Public check6 As Integer
    End Structure
    Public W1_Head As Integer

    Private W7101 As T7101_AREA
    Private W7171 As T7171_AREA
    Public HLP0001_KIEMTRA As KIEMTRA
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub
    Public Function DATA_SEARCH01(Head_No As Long) As Boolean
        Dim i As Integer

        DATA_SEARCH01 = False

        Try
            Vs1.Sheets(0).Rows.Count = 0
            cmd_OK.Enabled = False
            DS1 = PrcDS("USP_HLP7101A_SEARCH_VS1", cn, "*" & SelectLabelSearch1.PeaceTextbox1.Text.Trim, _
                                          chk_Customer.CheckState, chk_Buyer.CheckState, chk_Inbound.CheckState, _
                                          chk_Outbound.CheckState, chk_Material.CheckState, chk_Others.CheckState)
            If GetDsRc(DS1) = 0 Then
                Vs1.Visible = True
                Exit Function
            End If
            SPR_SET(Vs1, , , , OperationMode.SingleSelect)
            For i = 0 To GetDsRc(DS1) - 1
                Vs1.ActiveSheet.RowCount = i + 1
                setData(Vs1, 0, i, GetDsData(DS1, i, "CustomerCode"))
                setData(Vs1, 1, i, GetDsData(DS1, i, "CustomerName"))
                setData(Vs1, 2, i, GetDsData(DS1, i, "DevelopmentCode"))
            Next
            cmd_OK.Enabled = True

            Vs1.ActiveSheet.Columns(0).Visible = False

            Me.Show()
            Application.DoEvents()
            Vs1.Focus()

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Overridable Sub HLP0001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""
        Me.Text = HLPNA

        Me.Show()
        Application.DoEvents()
        Setfocus(SelectLabelSearch1)
    End Sub

   
    Private Sub SelectLabelSearch1_KeyDown(sender As Object, e As KeyPressEventArgs) Handles SelectLabelSearch1.txtTextKeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmd_SEARCH.PerformClick()
        End If
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH01(W1_Head)
    End Sub

    Public Overridable Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            Exit Sub
        Else
            hlp0000SeVaTt = getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex)
        End If
        Me.Dispose()
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.Row < 0 Then Exit Sub
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            Exit Sub
        Else
            hlp0000SeVaTt = getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex)
        End If
        Me.Dispose()
    End Sub

    Private Sub Vs1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Vs1.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter), ChrW(Keys.Escape) : cmd_OK.PerformClick()

        End Select
    End Sub

    Private Sub cmd_Cancel_Click_1(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        Me.Dispose()
    End Sub
End Class