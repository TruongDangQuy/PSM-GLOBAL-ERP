Public Class HLP7231F

#Region "Variable"
    Public W1_Head As Integer

#End Region

#Region "Form_Load"
    Public Function Link_HLP7231F(BasicName As String) As Boolean
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""
        hlp0000SeVaTt1 = ""
        txt_Name.Data = BasicName
        hlpCHK = False

        Me.ShowDialog()

        Link_HLP7231F = hlpCHK
    End Function
    Public Overridable Sub HLP0001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""
        hlp0000SeVaTt1 = ""
        hlpCHK = False
        'Me.WindowState = FormWindowState.Maximized


        Setfocus(txt_Name)
    End Sub
#End Region

#Region "Methods"
    Public Function DATA_SEARCH01(Head_No As Long) As Boolean
        DATA_SEARCH01 = False

        Try
            DS1 = PrcDS("USP_HLP7231F_SEARCH_VS1", cn, "*" & txt_Name.Data, txt_Width.Data, txt_Height.Data, txt_SizeName.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231F_SEARCH_VS1", "Vs1")
                Vs1.ActiveSheet.RowCount = 0
                Vs1.Enabled = True
                Exit Function
            End If
            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231F_SEARCH_VS1", "Vs1", , True)

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
        If getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            hlpCHK = False
            Exit Sub
        Else
            hlp0000SeVaTt = getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(Vs1, getColumIndex(Vs1, "MaterialName"), Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt1 = getData(Vs1, getColumIndex(Vs1, "MaterialName"), Vs1.ActiveSheet.ActiveRowIndex)
            hlpCHK = True
        End If
        Me.Dispose()
    End Sub


    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick

        If getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            hlpCHK = False
            Exit Sub
        Else
            hlp0000SeVaTt = getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(Vs1, getColumIndex(Vs1, "MaterialName"), Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt1 = getData(Vs1, getColumIndex(Vs1, "MaterialName"), Vs1.ActiveSheet.ActiveRowIndex)
            hlpCHK = True
        End If
        Me.Dispose()
    End Sub

    Private Sub cmd_Cancel_Click_1(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""
        hlp0000SeVaTt1 = ""
        hlpCHK = False
        Me.Dispose()
    End Sub

    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmd_OK.PerformClick()
        End If
    End Sub

    Private Sub txt_Add_Click(sender As Object, e As EventArgs)
        If ISUD7231S.Link_ISUD7231S(1, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex), "PFP70231") = False Then Exit Sub

        Call DATA_SEARCH01(W1_Head)
    End Sub
#End Region

End Class