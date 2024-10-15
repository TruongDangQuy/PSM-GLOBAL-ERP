Public Class HLP7210A

#Region "Variable"
    Private Dsu01 As Long
    Private W1_Head As Integer = 2
    Private wGCHK As String

    Private W7210 As T7210_AREA
    Private vschkbx As New FarPoint.Win.Spread.CellType.CheckBoxCellType
    Private WCHK As String
#End Region

#Region "Form_Load"
    Public Function Link_HLP7210A(CustomerCode As String, Optional CHK1 As String = "") As Boolean

        W7210.CustomerCode = CustomerCode


        If READ_PFK7101(CustomerCode) Then
            txt_CustomerCode.Data = D7101.CustomerName
            txt_CustomerCode.Code = D7101.CustomerCode
            txt_CustomerCode.Enabled = True
        End If

        If CHK1 <> "" Then WCHK = CHK1

        Me.ShowDialog()

        Link_HLP7210A = hlpCHK

        If hlpCHK = False Then Call D7109_CLEAR()

    End Function

    Private Sub HLP7210A_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        SPR_CLEAR(VS1)
        SPR_SET(VS1, , , , OperationMode.SingleSelect, True)
        If DATA_SEARCH01() = False Then
            Exit Sub
        End If

    End Sub
#End Region

#Region "Methods"
    Public Overridable Function DATA_SEARCH01() As Boolean
        Dim i As Integer

        DATA_SEARCH01 = False
        VS1.Sheets(0).RowCount = 0

        Try
            DS1 = PrcDS("USP_HLP7210A_SEARCH_VS1", cn, "*" & txt_CustomerCode.Code, txt_TypeName.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(VS1, DS1, "USP_HLP7210A_SEARCH_VS1", "Vs1")
                VS1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(VS1, DS1, "USP_HLP7210A_SEARCH_VS1", "Vs1")
            DATA_SEARCH01 = True

        Catch ex As Exception

            Call MsgBoxP("DATA_SEARCH01", vbCritical)
        End Try
    End Function
    Public Function DATA_SEARCH02() As Boolean
        Dim i As Integer

        DATA_SEARCH02 = False
        VS2.Sheets(0).RowCount = 0
        Dim CartonCode As String = getData(VS1, getColumIndex(VS1, "CartonCode"), VS1.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_HLP7210A_SEARCH_VS2", cn, CartonCode, txt_Article.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(VS2, DS1, "USP_HLP7210A_SEARCH_VS2", "VS2")
                VS2.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(VS2, DS1, "USP_HLP7210A_SEARCH_VS2", "VS2")
            DATA_SEARCH02 = True

        Catch ex As Exception

            Call MsgBoxP("DATA_SEARCH01", vbCritical)
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub SelectLabelSearch1_Load(sender As Object, e As KeyEventArgs) Handles txt_TypeName.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then DATA_SEARCH01()
    End Sub
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        hlpCHK = False
        D7210_CLEAR()
        Me.close()
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH01()
    End Sub


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            D7210_CLEAR()
            Exit Sub
        Else
            hlp0000SeVaTt = getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt1 = getData(VS1, 1, VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(VS1, 2, VS1.ActiveSheet.ActiveRowIndex)

            hlpCHK = True
        End If
        Me.close()
    End Sub


    Private Sub VS1_CellClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellClick
        If e.Row < 0 Then Exit Sub
        VS1.ActiveSheet.ActiveRowIndex = e.Row
        VS1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub VS1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellDoubleClick
        Call DATA_SEARCH02()
    End Sub

    Private Sub VS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VS1.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter) : cmd_OK.PerformClick()
            Case ChrW(Keys.Escape) : cmd_Cancel.PerformClick()
        End Select
    End Sub

    Private Sub txt_Add_Click(sender As Object, e As EventArgs) Handles txt_Add.Click
        If ISUD7210A.Link_ISUD7210A(1, "000000", "PFP72100") = False Then Exit Sub
        Call DATA_SEARCH01()
    End Sub
#End Region

End Class