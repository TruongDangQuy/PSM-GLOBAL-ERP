Public Class PFP71711

#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private Form_Close As Boolean
#End Region

#Region "Form Load - Toolstrip"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim xISUD7232A As String
        xISUD7232A = ISUD7232A.Text

        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False, WordConv("INPUT") & "(F5)")
      
        Call FORM_INIT()
        Call DATA_INIT()
    End Sub
    Private Sub FORM_INIT()


    End Sub

    Private Sub DATA_INIT()

    End Sub

    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB01()
                Case Keys.F6 : Call MAIN_JOB02()
                Case Keys.F7 : Call MAIN_JOB03()
                Case Keys.F8 : Call MAIN_JOB04()
                Case Keys.F9 : Call MAIN_JOB05()
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
        If sender.Equals(tst_1) Then
            MAIN_JOB01()
        End If
        If sender.Equals(tst_2) Then
            MAIN_JOB02()
        End If
        If sender.Equals(tst_3) Then
            MAIN_JOB03()
        End If
        If sender.Equals(tst_4) Then
            MAIN_JOB04()
        End If
    End Sub

    Private Sub MAIN_JOB01()
     
    End Sub

    Private Sub MAIN_JOB02()
     

    End Sub

    Private Sub MAIN_JOB03()
     
    End Sub

    Private Sub MAIN_JOB04()
   
    End Sub


    Private Sub MAIN_JOB05()

    End Sub

#End Region

#Region "Data Search"
    Private Function DATA_SEARCH01() As Boolean

        vS1.Enabled = False
        DATA_SEARCH01 = False

        DS1 = PrcDS("USP_PFP71711_SEARCH_VS1", cn, "*" & txt_Name.Data)

        If GetDsRc(DS1) = 0 Then
            vS1.Enabled = True
            SPR_PRO_NEW(vS1, DS1, "USP_PFP71711_SEARCH_VS1", "Vs1")
            Exit Function
        End If

        SPR_PRO_NEW(vS1, DS1, "USP_PFP71711_SEARCH_VS1", "Vs1")
        DATA_SEARCH01 = True

        vS1.Enabled = True

    End Function

    Private Function DATA_SEARCH02() As Boolean

        vS2.Enabled = False
        DATA_SEARCH02 = False

        vS2.ActiveSheet.RowCount = NumericUpDown1.Value
        vS2.ActiveSheet.ColumnCount = NumericUpDown2.Value

        vS2.ActiveSheet.RowHeader.Visible = True
        vS2.ActiveSheet.ColumnHeader.Visible = True

        Dim xGridLine As New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLines.None)

        vS2.ActiveSheet.VerticalGridLine = xGridLine
        vS2.ActiveSheet.HorizontalGridLine = xGridLine

        'DS1 = PrcDS("USP_PFP71711_SEARCH_vS2", cn, "*" & txt_Name.Data)

        'If GetDsRc(DS1) = 0 Then
        '    vS2.Enabled = True
        '    SPR_PRO_NEW(vS2, DS1, "USP_PFP71711_SEARCH_vS2", "vS2")
        '    Exit Function
        'End If

        'SPR_PRO_NEW(vS2, DS1, "USP_PFP71711_SEARCH_vS2", "vS2")
        'DATA_SEARCH02 = True

        vS2.Enabled = True

    End Function
    Private Function LINE_MOVE_DISPLAY01() As Boolean
        
    End Function

#End Region

#Region "Spread"


    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles vS1.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INPUT") & "(F5)", WordConv("SEARCH") & "(F6)", WordConv("UPDATE") & "(F7)", WordConv("DELETE") & "(F8)")

    End Sub

    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles vS1.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False, WordConv("INPUT") & "(F5)", WordConv("SEARCH") & "(F6)", WordConv("UPDATE") & "(F7)", WordConv("DELETE") & "(F8)")
    End Sub

    Private Sub vS1_CellDoubleClick(sender As Object, e As CellClickEventArgs)
        Call MAIN_JOB02()
    End Sub

#End Region

#Region "Event"
    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellClick
        Dim MaterialCode As String
        Dim Xrow As Integer

        Xrow = e.Row

        MaterialCode = getData(vS1, getColumIndex(vS1, "MaterialCode"), Xrow)

        If MaterialCode = "" Then Exit Sub



    End Sub
    Private Sub vS1_CellDoubleClick1(sender As Object, e As CellClickEventArgs) Handles vS1.CellDoubleClick
        Dim Key_BasicSel As String
        Dim Key_BasicCode As String

        Key_BasicSel = getData(vS1, getColumIndex(vS1, "Key_BasicSel"), e.Row)
        Key_BasicCode = getData(vS1, getColumIndex(vS1, "Key_BasicCode"), e.Row)

        If READ_PFK7171(Key_BasicSel, Key_BasicCode) Then
            setData(vS2, vS2.ActiveSheet.ActiveColumnIndex, vS2.ActiveSheet.ActiveRowIndex, D7171.BasicName)
            setCell(vS2, vS2.ActiveSheet.ActiveColumnIndex, vS2.ActiveSheet.ActiveRowIndex, D7171.BasicSel & D7171.BasicCode)
        End If

    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Call DATA_SEARCH01()
        Call DATA_SEARCH02()
    End Sub

    Private Sub Cms_1_Click(sender As Object, e As EventArgs) Handles Cms_1.ItemClicked
        Select Case True
            Case Cms_1.Items(0).Selected
                Cms_1.Hide()
                Call MAIN_JOB01()

            Case Cms_1.Items(1).Selected
                Cms_1.Hide()
                Call MAIN_JOB02()

            Case Cms_1.Items(2).Selected
                Cms_1.Hide()
                Call MAIN_JOB03()

            Case Cms_1.Items(3).Selected
                Cms_1.Hide()
                Call MAIN_JOB04()
        End Select
    End Sub

#End Region

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class