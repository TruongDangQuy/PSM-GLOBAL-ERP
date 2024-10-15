Public Class HLP7231C_M

#Region "Variable"
    Public W1_Head As Integer

#End Region

#Region "Form_Load"
    Public Overridable Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        Vs1.ActiveSheet.RowCount = 0
        DATA_SEARCH01(W1_Head)
    End Sub
#End Region

#Region "Methods"
    Public Function DATA_SEARCH01(Head_No As Long) As Boolean
        DATA_SEARCH01 = False
        If txt_cdLargeGroupMaterial.Code = "" Then txt_cdLargeGroupMaterial.Code = "001"
        Try
            DS1 = PrcDS("USP_HLP7231C_SEARCH_VS1_M", cn, "*" & txt_Name.Data, txt_cdLargeGroupMaterial.Data, txt_cdSemiGroupMaterial.Data, _
                        txt_cdDetailGroupMaterial.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231C_SEARCH_VS1_M", "Vs1")
                Vs1.ActiveSheet.RowCount = 0
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231C_SEARCH_VS1_M", "Vs1")

            Me.Show()
            Application.DoEvents()
            Vs1.Focus()

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub SelectLabelSearch1_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txt_Name.txtTextKeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmd_SEARCH.PerformClick()
        End If
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH01(W1_Head)
    End Sub

    Public Overridable Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""

        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) IsNot Nothing Then
            Dim i As Integer
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(Vs1, getColumIndex(Vs1, "CheckUse"), i) = "1" Then
                    'If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) <> "" Then
                    hlp0000SeVa &= getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), i) & ","
                End If
            Next
            hlp0000SeVa = Strings.Left(hlp0000SeVa, Len(hlp0000SeVa) - 1)
            hlp0000SeVaTt = hlp0000SeVa
        Else
            hlp0000SeVa = ""
            hlp0000SeVaTt = ""
        End If
        Me.Dispose()

    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs)
        If e.Row < 0 Then Exit Sub
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub cmd_Cancel_Click_1(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""
        hlp0000SeVaTt1 = ""
        Me.Close()
    End Sub

    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmd_OK.PerformClick()
        End If
    End Sub
#End Region

    


    

    

   
End Class