Public Class HLP7171ALL

#Region "Variable"
    Private Dsu01 As Long
    Private W1_Head As Integer = 2
    Private wGCHK As String

    Private W7171 As T7171_AREA
    Private vschkbx As New FarPoint.Win.Spread.CellType.CheckBoxCellType
    Private WCHK As String
#End Region

#Region "Form_Load"
    Public Function Link_HLP7171A(BasicSel As String, BasicName As String) As Boolean
        If BasicSel <> "" Then HLPNA = BasicSel

        W7171.BasicSel = BasicSel
        W7171.BasicName = BasicName

        txt_Name.Data = BasicName

        Me.ShowDialog()

        Link_HLP7171A = hlpCHK
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
        Dim Check1 As String
        Dim Check2 As String
        Dim Check3 As String
        Dim Check4 As String
        Dim Check5 As String
        Dim Check6 As String
        Dim Check7 As String
        Dim Check8 As String
        Dim Check9 As String
        Dim Check10 As String

        Try
            If SELCON(HLPNA) = "002" And Chk717_CheckProd = True Then
                Check1 = ""
                Check2 = "1"
                Check3 = ""
                Check4 = ""
                Check5 = ""
                Check6 = ""
                Check7 = ""
                Check8 = ""
                Check9 = ""
                Check10 = ""

                DS1 = PrcDS("USP_HLP7171A_SEARCH_vS1_F1", cn, SELCON(HLPNA), txt_Name.Data,
                        Check1,
                        Check2,
                        Check3,
                        Check4,
                        Check5,
                        Check6,
                        Check7,
                        Check8,
                        Check9,
                        Check10)

                If GetDsRc(DS1) = 0 Then
                    SPR_PRO_NEW(VS1, DS1, "USP_HLP7171A_SEARCH_vS1", "Vs1")
                    VS1.Enabled = True
                    Exit Function
                End If

            ElseIf Chk717_CheckAcc = True Then
                Check1 = ""
                Check2 = ""
                Check3 = ""
                Check4 = ""
                Check5 = ""
                Check6 = ""
                Check7 = "1"
                Check8 = ""
                Check9 = ""
                Check10 = ""

                DS1 = PrcDS("USP_HLP7171A_SEARCH_vS1_F1", cn, SELCON(HLPNA), txt_Name.Data,
                        Check1,
                        Check2,
                        Check3,
                        Check4,
                        Check5,
                        Check6,
                        Check7,
                        Check8,
                        Check9,
                        Check10)

                If GetDsRc(DS1) = 0 Then
                    SPR_PRO_NEW(VS1, DS1, "USP_HLP7171A_SEARCH_vS1", "Vs1")
                    VS1.Enabled = True
                    Exit Function
                End If

            Else

                If ChkCdLarge = True Then
                    DS1 = PrcDS("USP_HLP7171A_SEARCH_vS1_MASTER", cn, SELCON(HLPNA), txt_Name.Data, ValueCdLarge)
                    If GetDsRc(DS1) = 0 Then DS1 = PrcDS("USP_HLP7171A_SEARCH_vS1", cn, SELCON(HLPNA), txt_Name.Data)
                Else
                    DS1 = PrcDS("USP_HLP7171A_SEARCH_vS1", cn, SELCON(HLPNA), txt_Name.Data)
                End If

                If GetDsRc(DS1) = 0 Then
                    SPR_PRO_NEW(VS1, DS1, "USP_HLP7171A_SEARCH_vS1", "Vs1")
                    VS1.Enabled = True
                    Exit Function
                End If

            End If

            SPR_PRO_NEW(VS1, DS1, "USP_HLP7171A_SEARCH_vS1", "Vs1")
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