Public Class HLP7171D_SCANOFFLINE

#Region "Variable"
    Private Dsu01 As Long
    Private W1_Head As Integer = 2
    Private wGCHK As String

    Private W7171 As T7171_AREA
    Private vschkbx As New FarPoint.Win.Spread.CellType.CheckBoxCellType
    Private WCHK As String

    Private BasicSel As String
    Private BasicName As String
    Private cdFactory As String
    Private cdMainProcess As String
    Private cdSubProcess As String
    Private cdLineProd As String
#End Region

#Region "Form_Load"
    Public Function Link_HLP7171D(BasicSel As String, BasicName As String, cdFactory As String, cdMainProcess As String, cdSubProcess As String, cdLineProd As String) As Boolean
        If BasicSel <> "" Then HLPNA = BasicSel

        Me.BasicSel = BasicSel
        Me.BasicName = BasicName
        Me.cdFactory = cdFactory
        Me.cdMainProcess = cdMainProcess
        Me.cdSubProcess = cdSubProcess
        Me.cdLineProd = cdLineProd

        txt_Name.Data = BasicName

        Me.ShowDialog()

        Link_HLP7171D = hlpCHK
    End Function

    Private Sub HLP0000_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        SPR_CLEAR(VS1)
        SPR_SET(VS1, , , , OperationMode.SingleSelect, True)
        If DATA_SEARCH01() = False Then
            Exit Sub
        End If

    End Sub
#End Region

#Region "Methods"
    Public Overridable Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        DS1 = New DataSet
        Try
            DS1 = PrcDS("USP_HLP7171D_SCANOFFLINE_SEARCH_vS1", cn, Me.BasicSel, txt_Name.Data, Me.cdFactory, Me.cdMainProcess, Me.cdSubProcess, Me.cdLineProd)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(VS1, DS1, "USP_HLP7171D_SCANOFFLINE_SEARCH_vS1", "Vs1")
                VS1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(VS1, DS1, "USP_HLP7171D_SCANOFFLINE_SEARCH_vS1", "Vs1")
            DATA_SEARCH01 = True

            Me.Show()
            Application.DoEvents()
            VS1.Select()

        Catch ex As Exception

            Call MsgBoxP("DATA_SEARCH01", vbCritical)
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub SelectLabelSearch1_Load(sender As Object, e As KeyEventArgs) Handles txt_Name.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then DATA_SEARCH01()
    End Sub
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlpCHK = False
        D7171_CLEAR()
        Me.Close()
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH01()
    End Sub


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(VS1, getColumIndex(VS1, "BasicCode"), VS1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            D7171_CLEAR()
            hlpCHK = False
            Exit Sub
        Else
            hlp0000SeVa = getData(VS1, getColumIndex(VS1, "BasicName"), VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt = getData(VS1, getColumIndex(VS1, "BasicCode"), VS1.ActiveSheet.ActiveRowIndex)
            Call READ_PFK7171(W7171.BasicSel, hlp0000SeVaTt)
            hlpCHK = True
        End If
        Me.Close()
    End Sub


    Private Sub VS1_CellClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellClick
        If e.Row < 0 Then Exit Sub
        VS1.ActiveSheet.ActiveRowIndex = e.Row
        VS1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub VS1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellDoubleClick
        If getData(VS1, getColumIndex(VS1, "BasicCode"), VS1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            D7171_CLEAR()
            hlpCHK = False
            Exit Sub
        Else
            hlp0000SeVa = getData(VS1, getColumIndex(VS1, "BasicName"), VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt = getData(VS1, getColumIndex(VS1, "BasicCode"), VS1.ActiveSheet.ActiveRowIndex)
            Call READ_PFK7171(W7171.BasicSel, hlp0000SeVaTt)
            hlpCHK = True
        End If
        Me.Close()
    End Sub

    Private Sub VS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VS1.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter) : cmd_OK.PerformClick()
            Case ChrW(Keys.Escape) : cmd_Cancel.PerformClick()
        End Select
    End Sub

    Private Sub txt_Add_Click(sender As Object, e As EventArgs) Handles txt_Add.Click
        If ISUD7171A.Link_ISUD7171A(1, SELCON(HLPNA), "001", "PFP71710") = False Then Exit Sub
        Call DATA_SEARCH01()
    End Sub
#End Region

End Class